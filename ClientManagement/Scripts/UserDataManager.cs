using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Scripts
{
    public class UserDataManager
    {
        private static UserDataManager instance;

        // ユーザーデータやその他の必要な情報を保持するプロパティなど
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                ChangeUser?.Invoke(this, EventArgs.Empty);
            }
        }
        private string name = default;
        public int ID { get; set; }

        public int GroupID { get; set; }

        public event EventHandler ChangeUser;

        private UserDataManager()
        {

        }

        public static UserDataManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserDataManager();
                }
                return instance;
            }
        }
    }

}
