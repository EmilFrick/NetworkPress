using NetworkPress.Data.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkPress.Data.Operations.OperationTemplates
{
    public class Operations
    {

        private readonly AppDbContext _db;

        public Operations(AppDbContext db)
        {
            _db = db;
        }


    }
}
