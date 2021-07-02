using System;
using System.Collections.Generic;
using System.Text;
using TimeRecorder.Domain;
using TimeRecorder.Domain.Domain.WorkProcesses;

namespace TimeRecorder.Repository.SQLite.WorkProcesses.Dao
{
    class WorkProcessTableRow
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int? Hide { get; set; }

        public int? DispOrder { get; set; }

        public WorkProcess ToDomainObject()
        {
			return new WorkProcess(new Identity<WorkProcess>(Id), Title, Hide.HasValue && Hide.Value == 1, DispOrder ?? 0);
		}

    }
}
