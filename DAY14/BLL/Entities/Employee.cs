using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Employee:EntityBase
    {
		public string emp_id { set; get; }
		public required string fname {  set; get; }
		public char? minit {  set; get; }
		public required string lname { set; get; }
		public required short job_id {  set; get; }
		public int? job_lvl {  set; get; }
		public required string pub_id {  set; get; }
		public required DateTime hire_date {  set; get; }
        /*
      [emp_id] [dbo].[empid] NOT NULL,
	[fname] [varchar](20) NOT NULL,
	[minit] [char](1) NULL,
	[lname] [varchar](30) NOT NULL,
	[job_id] [smallint] NOT NULL,
	[job_lvl] [tinyint] NULL,
	[pub_id] [char](4) NOT NULL,
	[hire_date] [datetime] NOT NULL,
        */
    }
}
