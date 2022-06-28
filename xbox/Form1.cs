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
		/// поле с геймпадом.
		/// </summary>
		Gamepad gp;
		Timer timer;
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

		private async void Timer_Tick(object sender, EventArgs e)
		{
			if (Gamepad.Gamepads.Count > 0)
			{
				gp = Gamepad.Gamepads.First();
				GamepadVibration gpvb = new GamepadVibration();
				var Reading = gp.GetCurrentReading();
				switch (Reading.Buttons)
				{
					case GamepadButtons.A:
						await Log("A нажат.");
						Vibrate();
						await Log("пройдена функция Form1.Vibrate()");
						break;
				}
				if (Reading.LeftTrigger != 0)
				{
					await Log($"уровень нажатия на левый тригер: {Reading.LeftTrigger}");
					gpvb.LeftMotor = Reading.LeftTrigger;
					gp.Vibration = gpvb;
				}
				else
				{
					gpvb.LeftMotor = 0;
					gp.Vibration = gpvb;
				}
				if (Reading.RightTrigger != 0)
				{
					await Log($"уровень нажатия на правый тригер: {Reading.RightTrigger}");
					gpvb.RightMotor = Reading.RightTrigger;
					gp.Vibration = gpvb;
				}
				else
				{
					gpvb.RightMotor = 0;
					gp.Vibration = gpvb;
				}
				//gp.Vibration.LeftTrigger;
			}
			//throw new NotImplementedException();
		}
		private void Vibrate()
		{
			GamepadVibration gamepadVibration = gp.Vibration;
			//gamepadVibration.RightTrigger = 1;
			gamepadVibration.LeftMotor = 0.5;
		}
		private async Task Log(string mess)
		{
			Task task = Task.Run(() => { Debug.WriteLine(DateTime.Now.ToString() + ": " + mess); });
			await task;
		}
		private async void Gamepad_GamepadAdded(object sender, Gamepad e)
		{
			await Log("ваш гп был подключён, радуйтесь.");
			//throw new NotImplementedException();
		}
		private async void Gamepad_GamepadRemoved(object sender, Gamepad e)
		{
			await Log("ваш гп был удалён, плачьте.");
			//throw new NotImplementedException();
		}
	}
}