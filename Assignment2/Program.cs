﻿using Assignment2.core;
using Assignment2.data;
using Assignment2.gui;

namespace Assignment2 {

	internal class Program {

		[STAThread]
		public static void Main(string[] args) {
			Configure();
			ShowBaseForm();
		}

		private static void ShowBaseForm() {
			new LoginForm().ShowDialog();
		}

		private static void Configure() {
			ProgramEnvironment.ActiveAccounts.Add(new Account("admin", "admin"));
			ProgramEnvironment.ActiveAccounts.Add(new Account("huymaster", ""));
		}
	}
}