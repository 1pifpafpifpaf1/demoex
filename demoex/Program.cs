﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoex
{
    public static class Auth
    {
        //Статичное поле, которое хранит значения ID пользователя
        public static int auth_id = 0;
        //Статичное поле, которое хранит значения ФИО пользователя
        public static string auth_fio = null;
        //Статичное поле, которое хранит количество привелегий пользователя
        public static int auth_role = 0;
    }
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Авторизация());
        }
    }
}
