﻿namespace AbstractFactory.Common
{
    /* Concret SqlConnection */
    public class SqlConnection : DbConnection
    {
        public override void Open()
        {
            Console.WriteLine(&amp; amp; amp; amp; quot; Método Open de SQL Connection foi chamado...&amp; amp; amp; amp; quot;);
        }
    }
}
