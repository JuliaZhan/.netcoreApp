using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSVApp.Common
{
    public class ConfigurationManager
    {
        private static IConfigurationRoot config = null;
        private static string _defaultPath = Directory.GetCurrentDirectory()+"\\app.json" ;
        //private static string rootdir = AppContext.BaseDirectory;
        //private static DirectoryInfo Dir = Directory.GetParent(rootdir);
        //private static string root = Dir.Parent.Parent.Parent.FullName+"\\app.json";
        static ConfigurationManager()
        {
            // Microsoft.Extensions.Configuration扩展包提供的
            var builder = new ConfigurationBuilder()
                .AddJsonFile(_defaultPath);
            config = builder.Build();
        }

        public static IConfigurationRoot AppSettings
        {
            get
            {
                return config;
            }
        }

        public static string Get(string key)
        {
            return config[key];
        }
    }
}
