using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using Microsoft.AspNet.Identity;
using SimpleBlog.DAL.Context;
using SimpleBlog.DAL.Object_Model;

namespace SimpleBlog.WebUI.Utils
{
    public class BlogDbInitializer : DropCreateDatabaseIfModelChanges<ApplicationContext>
    {
        /// <summary>
        /// Seeds the specified context.
        /// </summary>
        /// <param name="context">The context.</param>
        protected override void Seed(ApplicationContext context)
        {
            if (SettingsProvider.IsInitDb)
            {
                InitDb(context);
            }
            base.Seed(context);
        }

        /// <summary>
        /// Initializes the database.
        /// </summary>
        /// <param name="context">The context.</param>
        private void InitDb(ApplicationContext context)
        {
            Tag tag = new Tag()
            {
                Name = "C#",
                Description = "Lorem ipsum dolor sit amet",
                UrlSlug = "c-sharp",
            };
            Post post = new Post()
            {
                Description =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis mattis tincidunt facilisis. Pellentesque posuere dui risus, at consectetur sapien consequat ac. Praesent viverra sollicitudin magna, quis pulvinar quam vestibulum vitae. Curabitur dignissim enim sit amet pellentesque porttitor. Vestibulum leo felis, tristique ac sagittis a, imperdiet non arcu. Aliquam molestie quam quis facilisis lobortis. Duis vitae maximus dui, et finibus enim. Maecenas porttitor pellentesque bibendum. Integer nec aliquam quam, eu auctor erat. In hac habitasse platea dictumst. Praesent feugiat nibh eros, sit amet ornare ligula pretium vel. In ac aliquet quam. Aliquam maximus velit quam, vel efficitur odio facilisis pharetra. Quisque ut tempus arcu. Phasellus pulvinar orci risus, quis pretium nulla posuere quis. Curabitur vel neque convallis, porta est sit amet, dapibus quam. Nulla vel erat sit amet felis maximus condimentum in ut nulla. In egestas venenatis accumsan. Pellentesque quis mollis nibh. Vivamus ullamcorper vulputate turpis non imperdiet. Aenean nisl eros, accumsan eget sem nec, faucibus pellentesque tortor. Sed at tristique quam. Quisque nec lectus elementum, ultrices risus at, accumsan est. Cras dapibus dolor id nibh vestibulum fringilla. Ut eleifend in massa eu bibendum. Nullam facilisis turpis ligula, in posuere nulla condimentum quis. Vivamus a dui non elit luctus ultrices eu sed metus. In iaculis mauris at bibendum fermentum. Phasellus justo libero, tincidunt et eros eu, finibus consequat lacus. Nunc egestas ultricies sagittis. Nam pharetra mi sit amet metus venenatis suscipit. Sed venenatis, ipsum nec tempus dictum, purus risus dignissim dui, nec varius nunc lacus mollis sapien. Morbi convallis placerat nunc, eu pharetra quam rutrum in. Proin dapibus non ante eu laoreet. Phasellus massa purus, hendrerit nec risus sed, fermentum elementum ligula. Vivamus quis nibh mi. Ut a dolor a nisl tempor mattis. Maecenas non varius nisl. Nullam accumsan ante ipsum, sed porttitor leo interdum id. Donec purus felis, rhoncus non tellus a, accumsan egestas lectus. Sed augue orci, ornare id elit sed, consequat ullamcorper est. Donec ut auctor elit, eu euismod dolor. Vestibulum sed commodo est. In laoreet arcu sed arcu cursus, vitae elementum arcu mattis. Quisque felis eros, mollis a orci eu, efficitur pharetra purus. In at iaculis nisl. Nulla iaculis aliquam libero. Morbi consectetur aliquet magna, quis malesuada nisi vehicula nec. Quisque a lorem consectetur, venenatis ligula eu, faucibus nunc. Etiam congue feugiat luctus. Aenean hendrerit congue velit, nec porttitor libero sagittis eget. Curabitur semper consectetur ex. Proin suscipit urna pellentesque nisi commodo, suscipit rutrum mi aliquet. Mauris vitae placerat augue, non fringilla justo.",
                UrlSlug = "Est-mongo",
                Title = "Есть много вариантов Lorem Ipsum, но большинство из них имеет не всегда приемлемые модификации",
                ShortDescription =
                    "Есть много вариантов Lorem Ipsum, но большинство из них имеет не всегда приемлемые модификации, например, юмористические вставки или слова, которые даже отдалённо не напоминают латынь. Если вам нужен Lorem Ipsum для серьёзного проекта, вы наверняка не хотите какой-нибудь шутки, скрытой в середине абзаца.",
                IsPublished = true,
                PublishDate = DateTime.Now,
                Tags = new List<Tag>()
                {
                    tag,
                },
            };


            var passwordHash = new PasswordHasher();
            ApplicationUser user = new ApplicationUser()
            {
                Email = SettingsProvider.DefaultUserEmail,
                EmailConfirmed = true,
                UserName = SettingsProvider.DefaultUser,
                FullName = SettingsProvider.DefaultUserFullName,
                PasswordHash = passwordHash.HashPassword(SettingsProvider.DefaultUserPassword),
                SecurityStamp = Guid.NewGuid().ToString(),
                Tags = new List<Tag>()
                {
                    tag
                },
                Posts = new List<Post>()
                {
                    post
                }
            };


            post.Author = user;
            tag.Author = user;

            context.Users.AddOrUpdate(applicationUser => applicationUser.Email, user);
            context.Posts.Add(post);

            context.SaveChanges();
        }
    }
}