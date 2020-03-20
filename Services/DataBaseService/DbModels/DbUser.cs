using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataBaseService.DbModels
{
    public class DbUser : IEquatable<DbUser>
    {
        readonly string id;
        readonly string login;
        readonly string email;
        readonly string password;

        public DbUser(string id, string login, string email, string password)
        {
            this.id = id;
            this.login = login;
            this.email = email;
            this.password = password;
        }

        public string Id
        {
            get => id;
        }
        public string Login
        {
            get => login;
        }
        public string Email
        {
            get => email;
        }
        public string Password
        {
            get => password;
        }

        public static bool operator ==(DbUser user1, DbUser user2)
        {
            return user1.Equals(user2);
        }
        public static bool operator !=(DbUser user1, DbUser user2)
        {
            return !user1.Equals(user2);
        }

        public bool Equals(DbUser other)
        {
            if (other == null)
                return false;

            return this.Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            DbUser otherUser = obj as DbUser;

            if (otherUser == null)
                return false;
            else
                return this.Equals(otherUser);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    public class UserEFConfigure : IEntityTypeConfiguration<DbUser>
    {
        public void Configure(EntityTypeBuilder<DbUser> builder)
        {
            throw new NotImplementedException();
        }
    }
}
