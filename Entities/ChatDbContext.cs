using System;
using System.Collections.Generic;
using System.Configuration;
using System.IdentityModel.Claims;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Chat.Entities
{
    internal class ChatDbContext : DbContext
    {
        /*private string _connectionString =
            "Server=localhost;Database=ChatDb;Trusted_Connection=true;TrustServerCertificate=true;";*/
        /*private string _connectionString =
            "Server=BPX-SIEWISE2;Database=ChatDb;Trusted_Connection=true;TrustServerCertificate=true;";*/
        public ChatDbContext(){}

        public ChatDbContext(DbContextOptions<ChatDbContext> option): base(option) { }


        public DbSet<ConversationUser> ConversationUsers { get; set; }
        public DbSet<Conversation> Conversations { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<RightRole> RightRoles { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Right> Rights { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RightRole>(rig => 
            {
                rig.HasOne(r => r.Role)
                .WithMany(rr => rr.RightRoles)
                .HasForeignKey(rr => rr.RoleId);

                rig.HasOne(r => r.Right)
                .WithMany(rr => rr.RightRoles)
                .HasForeignKey(rr => rr.RightId);
            
            });

            modelBuilder.Entity<Conversation>(con => 
            {
                con.HasMany(c => c.Messages)
                 .WithOne(m => m.Conversation);

                con.HasOne(c => c.Room)
                .WithMany(r => r.Conversations)
                .HasForeignKey(r => r.RoomId);

            });

            modelBuilder.Entity<ConversationUser>(con => 
            {
                con.HasOne(u => u.User)
                .WithMany(cu => cu.ConversationUsers)
                .HasForeignKey(cu => cu.UserId);

                con.HasOne(c => c.Conversation)
                .WithMany(cu => cu.ConversationUsers)
                .HasForeignKey(cu => cu.ConversationId);
            });

            modelBuilder.Entity<User>(us => 
            {
                us.HasOne(r => r.Role)
                .WithMany(u => u.Users)
                .HasForeignKey(u => u.RoleId);
            });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string[] connectionType = { "Work", "Priv" };
            /*optionsBuilder.UseSqlServer(_connectionString);*/

            /*if (!optionsBuilder.IsConfigured)
            {*/
                optionsBuilder.UseSqlServer(
                    ConfigurationManager.ConnectionStrings[connectionType[1]].ConnectionString
                /*ConfigurationManager.ConnectionStrings["Priv"].ConnectionString*/
                /*ConfigurationManager.ConnectionStrings["Work"].ConnectionString*/
                );
            /*}*/
        }
    } 
}
