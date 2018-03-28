using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnePlace.Database.Entity
{
    public class DBProjectOneplace
    {
        public void SaveProject( Project newProject)
        {
            var dbEntity = new ProjectOnePlaceEntities();
            dbEntity.Projects.Add(newProject);
            dbEntity.SaveChanges();

        }
    }
}
