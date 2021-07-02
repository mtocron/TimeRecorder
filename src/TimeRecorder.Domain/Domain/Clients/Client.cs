using System;
using System.Collections.Generic;
using System.Text;
using TimeRecorder.Domain.Utility;

namespace TimeRecorder.Domain.Domain.Clients
{
    /// <summary>
    /// ユーザ を表します
    /// </summary>
    public class Client : Entity<Client>
    {
        public Identity<Client> Id { get; set; }

        public string Name { get; set; }

        public string KanaName { get; set; }

        public bool Hide { get; set; }

        public static Client Empty => new Client(Identity<Client>.Empty, "未選択", "ミセンタク", false);

		public Client(Identity<Client> id, string name, string kanaName, bool hide)
		{
            Id = id;
            Name = name;
            KanaName = kanaName;
            Hide = hide;
        }

        protected override IEnumerable<object> GetIdentityValues()
        {
            yield return Id;
        }
    }
}
