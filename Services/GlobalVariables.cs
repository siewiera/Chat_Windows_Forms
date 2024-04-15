using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Services
{
    internal class GlobalVariables
    {
        private static GlobalVariables instance;

        public int globalId;
        public int globalLastConversationId;

        public GlobalVariables(){}

        public static GlobalVariables Instance
        {
            get 
            {
                if (instance == null)
                { 
                    instance = new GlobalVariables();
                }
                return instance;
            }
        }
    }
}
