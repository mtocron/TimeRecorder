using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeRecorder.Repository.SQLite.System.Versions
{
	class Version_000_011_000_000 : IVersion
	{
		public string CommandQuery => @"
ALTER TABLE products ADD COLUMN hide INTEGER DEFAULT 0;
ALTER TABLE products ADD COLUMN disporder INTEGER DEFAULT 0;
ALTER TABLE processes ADD COLUMN hide INTEGER DEFAULT 0;
ALTER TABLE processes ADD COLUMN disporder INTEGER DEFAULT 0;
ALTER TABLE clients ADD COLUMN hide INTEGER DEFAULT 0;";

		public string Version => "000.011.000.000";
	}
}
