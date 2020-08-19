using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDB.model
{
    public class UnitOfWork : IDisposable
    {
        private Context db = new Context();
        private Repository<Users> usersRepository;
        private Repository<Films> filmsRepository;
        private Repository<Attachments> attachRepository;

        public Repository<Users> Users
        {
            get
            {
                if (usersRepository == null)
                    usersRepository = new Repository<Users>(db);
                return usersRepository;
            }
        }

        public Repository<Films> Films
        {
            get
            {
                if (filmsRepository == null)
                    filmsRepository = new Repository<Films>(db);
                return filmsRepository;
            }
        }

        public Repository<Attachments> Attachments
        {
            get
            {
                if (attachRepository == null)
                    attachRepository = new Repository<Attachments>(db);
                return attachRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
