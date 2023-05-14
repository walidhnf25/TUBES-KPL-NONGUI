using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<User> users = new List<User>();
        bool loggedIn = false;
        User currentUser = null;

        while (true)
        {
            Console.WriteLine("1. Registrasi");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Logout");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Register(users);
                    break;
                case "2":
                    if (!loggedIn)
                    {
                        currentUser = Login(users);
                        if (currentUser != null)
                        {
                            loggedIn = true;
                            Console.WriteLine("Login berhasil!");
                        }
                        else
                        {
                            Console.WriteLine("password atau username salah.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("anda sudah login.");
                    }
                    break;
                case "3":
                    if (loggedIn)
                    {
                        loggedIn = false;
                        currentUser = null;
                        Console.WriteLine("berhasil keluar akun!");
                    }
                    else
                    {
                        Console.WriteLine("anda belum melakukan login.");
                    }
                    break;
                default:
                    Console.WriteLine("opsi tidak ditemukan.");
                    break;
            }
        }
    }

    static void Register(List<User> users)
    {
        Console.WriteLine("masukan username:");
        string username = Console.ReadLine();

        if (users.Exists(user => user.Username == username))
        {
            Console.WriteLine("Username sudah digunakan.");
            return;
        }

        Console.WriteLine("masukan password:");
        string password = Console.ReadLine();

        User newUser = new User(username, password);
        users.Add(newUser);

        Console.WriteLine("Registrasi berhasil!");
    }

    static User Login(List<User> users)
    {
        Console.WriteLine("Masukan username:");
        string username = Console.ReadLine();

        Console.WriteLine("Masukan password:");
        string password = Console.ReadLine();

        User user = users.Find(u => u.Username == username && u.Password == password);
        return user;
    }
}

class User
{
    public string Username { get; set; }
    public string Password { get; set; }

    public User(string username, string password)
    {
        Username = username;
        Password = password;
    }
}
