using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

using Classes.Webserver.Models;
using Microsoft.EntityFrameworkCore;

namespace Classes.Webserver.Data.MessageContext
{
    public static class MessageContextDbInitializer
    {
        public static void Initialize(MessageContext context)
        {
            context.Database.EnsureCreated();

            if (context.Messages.Any())
            {
                return; // DB already has data so do nothing.
            }            
        }
    }
}
