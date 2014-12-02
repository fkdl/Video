using System;
using System.Configuration;

namespace DotNet.Utilities
{
	/// <summary>
	/// web.config������
	/// </summary>
	public sealed class ConfigHelper
	{
		/// <summary>
		/// �õ�AppSettings�е������ַ�����Ϣ
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public static string GetConfigString(string key)
		{
            string CacheKey = "AppSettings-" + key;
            object objModel=null;
            
            try
            {
                objModel = ConfigurationManager.AppSettings[key];
            }
            catch (Exception e)
            {
                ShowException.ShowtheException("ConfigError", e);
            }
            return objModel.ToString();
		}

		/// <summary>
		/// �õ�AppSettings�е�����Bool��Ϣ
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public static bool GetConfigBool(string key)
		{
			bool result = false;
			string cfgVal = GetConfigString(key);
			if(null != cfgVal && string.Empty != cfgVal)
			{
				try
				{
					result = bool.Parse(cfgVal);
				}
				catch(FormatException e)
				{
                        ShowException.ShowtheException("ConfigError", e);
				}
			}
			return result;
		}
		/// <summary>
		/// �õ�AppSettings�е�����Decimal��Ϣ
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public static decimal GetConfigDecimal(string key)
		{
			decimal result = 0;
			string cfgVal = GetConfigString(key);
			if(null != cfgVal && string.Empty != cfgVal)
			{
				try
				{
					result = decimal.Parse(cfgVal);
				}
                catch (FormatException e)
                {

                    ShowException.ShowtheException("ConfigError", e);

                }
			}

			return result;
		}
		/// <summary>
		/// �õ�AppSettings�е�����int��Ϣ
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public static int GetConfigInt(string key)
		{
			int result = 0;
			string cfgVal = GetConfigString(key);
			if(null != cfgVal && string.Empty != cfgVal)
			{
				try
				{
					result = int.Parse(cfgVal);
				}
                catch (FormatException e)
                {

                    ShowException.ShowtheException("ConfigError", e);

                }
			}

			return result;
		}

        /// <summary>
        /// �޸�AppSettings�е�string��Ϣ
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="key"></param>
        public static void SetConfigString(string Value, string key)
        {
            
        }
        
	}
}
