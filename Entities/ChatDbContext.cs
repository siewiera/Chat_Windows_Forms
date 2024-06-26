﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.IdentityModel.Claims;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public DbSet<ControlForm> ControlForms { get; set; }
        public DbSet<RightControl> RightControls { get; set; }

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

            modelBuilder.Entity<RightControl>(rig =>
            {
                rig.HasOne(r => r.Right)
                .WithMany(rr => rr.RightControls)
                .HasForeignKey(rr => rr.RightId);

                rig.HasOne(r => r.ControlForm)
                .WithMany(rr => rr.RightControls)
                .HasForeignKey(rr => rr.ControlId);

            });

            modelBuilder.Entity<Conversation>(con =>
            {
                con.HasOne(c => c.Message)
                .WithMany(m => m.Conversations)
                .HasForeignKey(m => m.MessageId);

                con.HasOne(c => c.Room)
                .WithMany(r => r.Conversations)
                .HasForeignKey(r => r.RoomId);

                con.HasOne(cu => cu.ConversationUser)
                .WithMany(c => c.Conversations)
                .HasForeignKey(c => c.ConversationUserId);
            });

            modelBuilder.Entity<ConversationUser>(con => 
            {
                con.HasOne(u => u.User)
                .WithMany(cu => cu.ConversationUsers)
                .HasForeignKey(cu => cu.UserId);
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

            optionsBuilder.UseSqlServer(
                ConfigurationManager.ConnectionStrings[connectionType[1]].ConnectionString
            );
        }
    } 
}
