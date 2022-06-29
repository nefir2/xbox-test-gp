using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Windows.Gaming.Input;

namespace xbox
{
	public partial class Form1 : Form
	{
		/// <summary>
		/// подключённый геймпад.
		/// </summary>
		private Gamepad gp;
		/// <summary>
		/// таймер для проверки изменений с гп.
		/// </summary>
		private readonly Timer timer;
		/// <summary>
		/// конструктор формы.
		/// </summary>
		public Form1()
		{
			InitializeComponent();
			Gamepad.GamepadAdded += Gamepad_GamepadAdded;
			Gamepad.GamepadRemoved += Gamepad_GamepadRemoved;
			timer = new Timer();
			timer.Tick += Timer_Tick;
			timer.Interval = 1;
			timer.Start();
		}
		/// <summary>
		/// вывод отладочного сообщения.
		/// </summary>
		/// <remarks>
		/// пишет дату перед указанным сообщением.
		/// </remarks>
		/// <param name="mess">сообщение для вывода.</param>
		/// <returns>ожидание асинхронного выполнения.</returns>
		private async Task Log(string mess)
		{
			Task task = Task.Run(() => { Debug.WriteLine(DateTime.Now.ToString() + ": " + mess); });
			await task;
		}
		/// <summary>
		/// вывод сообщения в лейбл <see cref="PLUGIN"/>.
		/// </summary>
		/// <param name="color">цвет выводимого сообщения.</param>
		/// <param name="text">сообщение для вывода.</param>
		private void PLUGINText(Color color, string text)
		{
			PLUGIN.ForeColor = color;
			PLUGIN.Text = text;
		}
		/// <summary>
		/// при нажатии на лейбл, он скрывается.
		/// </summary>
		/// <remarks>
		/// при повторном нажатии видимость не вернётся.
		/// </remarks>
		/// <param name="sender">нажимаемый лейбл.</param>
		/// <param name="e"></param>
		private void HideLabel(object sender, EventArgs e)
		{
			Label clicked = sender as Label;
			clicked.Visible = !clicked.Visible; //более перестаёт быть нажимаемым.
		}
		/// <summary>
		/// обработчик тика таймера.
		/// </summary>
		/// <remarks>
		/// здесь находится весь код для гп.
		/// </remarks>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Timer_Tick(object sender, EventArgs e)
		{
			GPCount.Text = Gamepad.Gamepads.Count.ToString();
			if (Gamepad.Gamepads.Count > 0)
			{
				gp = Gamepad.Gamepads.First();
				GamepadVibration gpvb = new GamepadVibration();
				var Reading = gp.GetCurrentReading();
				BUTTON.Text = Reading.Buttons.ToString();
				if (Reading.LeftTrigger != 0)
				{
					//await Log($"уровень нажатия на левый тригер: {Reading.LeftTrigger}");
					LT.Text = $"{Reading.LeftTrigger}";
					if (motorsCheck.Checked) gpvb.LeftMotor = Reading.LeftTrigger;
					gp.Vibration = gpvb;
				}
				else
				{
					LT.Text = "0";
					gpvb.LeftMotor = 0;
					gp.Vibration = gpvb;
				}
				if (Reading.RightTrigger != 0)
				{
					//await Log($"уровень нажатия на правый тригер: {Reading.RightTrigger}");
					RT.Text = $"{Reading.RightTrigger}";
					if (motorsCheck.Checked) gpvb.RightMotor = Reading.RightTrigger;
					gp.Vibration = gpvb;
				}
				else
				{
					RT.Text = "0";
					gpvb.RightMotor = 0;
					gp.Vibration = gpvb;
				}
				if (Reading.LeftThumbstickY != 0) LSV.Text = Reading.LeftThumbstickY.ToString();
				else LSV.Text = 0.ToString();
				if (Reading.LeftThumbstickX != 0) LSH.Text = Reading.LeftThumbstickX.ToString();
				else LSH.Text = 0.ToString();
				if (Reading.RightThumbstickY != 0) RSV.Text = Reading.RightThumbstickY.ToString();
				else RSV.Text = 0.ToString();
				if (Reading.RightThumbstickX != 0) RSH.Text = Reading.RightThumbstickX.ToString();
				else RSH.Text = 0.ToString();
			}
		}
		/// <summary>
		/// обработчик события добавления гп.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Gamepad_GamepadAdded(object sender, Gamepad e)
		{
			//await Log("ваш гп был подключён, радуйтесь.");
			if (InvokeRequired) Invoke((Action<Color, string>)PLUGINText, Color.Green, "ваш гп был подключён, радуйтесь.");
			else PLUGINText(Color.Green, "ваш гп был подключён, радуйтесь.");
			if (Gamepad.Gamepads.Count > 0) GPNum.Enabled = true;
			GPNum.Maximum = Gamepad.Gamepads.Count;
		}
		/// <summary>
		/// обработчик события отключения гп.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Gamepad_GamepadRemoved(object sender, Gamepad e)
		{
			//await Log("ваш гп был удалён, плачьте.");
			if (InvokeRequired) Invoke((Action<Color, string>)PLUGINText, Color.Maroon, "ваш гп был удалён, плачьте.");
			else PLUGINText(Color.Maroon, "ваш гп был удалён, плачьте.");
			if (Gamepad.Gamepads.Count == 0) GPNum.Enabled = false;
		}
	}
}