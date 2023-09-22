﻿using System.Reflection;

namespace DesignPatterns.Structural.Decorator
{
    public class Post
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Body { get; set; }
        public override string ToString() => $"{Id} - {Title}";

        public void PrintProperties()
        {
            Type type = GetType();
            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                object? value = property.GetValue(this);
                Console.WriteLine($"{property.Name}: {value}");
            }
        }
    }
}
