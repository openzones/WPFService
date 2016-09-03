using OMInsurance.Log;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace OMInsurance.Services.Host
{
    public sealed class TypeLoader
    {
        private Assembly _assembly = null;
        private string _assemblyName = null;

        public TypeLoader(string assemblyName)
        {
            _assemblyName = assemblyName;
        }

        private Assembly GetAssembly()
        {
            if (_assembly == null)
            {
                try
                {
                    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _assemblyName);
                    _assembly = Assembly.LoadFrom(path);
                    FileLog.Info(string.Format("Assembly {0} is loaded.", path));
                }
                catch (Exception e)
                {
                    _assembly = null;
                    FileLog.Error(e);
                }
            }

            return _assembly;
        }

        public Type GetTypeByName(string name)
        {
            FileLog.Info(string.Format("Loading type {0} from assembly {1}.", name, _assemblyName));

            Type result = null;

            Assembly asm = GetAssembly();
            if (asm != null)
            {
                result = asm.GetType(name);
            }

            if (result == null)
            {
                FileLog.Warning(string.Format("Type {0} is not found in assembly {1}.", name, _assemblyName));
            }

            return result;
        }
    }
}
