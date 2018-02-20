// Description: Dapper Tutorial | Examples
// Website: http://dapper-tutorial.net/
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2017. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using Z.Dapper.Examples.API.Dapper.Methods;

namespace Z.Dapper.Examples.API.Dapper.Result
{
    public partial class Multi_Mapping : Form
    {
        public Multi_Mapping()
        {
            InitializeComponent();
        }

        private void MultiMapping_OneToOne(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Invoice_Select_WithDetail;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var invoices = connection.Query<Invoice, InvoiceDetail, Invoice>(
                        sql,
                        (invoice, invoiceDetail) =>
                        {
                            invoice.Detail = invoiceDetail;
                            return invoice;
                        },
                        splitOn: "InvoiceID")
                    .Distinct()
                    .ToList();

                My.Result.Show(invoices);
            }
        }

        private void MultiMapping_OneToMany(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Invoice_Select_WithItem;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                /*cria um dicionario para manter o controle dos invoices encontrados
                 * desta forma para cada linha que eu receber dentro da função eu posso adicionar seus 
                 * respectivos items caso contrario cada linha nova criaria um novo invoice */
                var invoiceDictionary = new Dictionary<int, Invoice>();

                /*os primeiros parametros indicam os tipos de entidade que voce quer que o dapper mapeie
                 * o ultimo parametro indica o tipo que voce vai retornar da query */
                var invoices = connection.Query<Invoice, InvoiceItem, Invoice>(
                        sql,
                        //essa func vai rodar para cada linha encontrada pela query
                        (invoice, invoiceItem) =>
                        {
                            Invoice invoiceEntry;
                            
                            /* caso eu ainda não tenha encontrado o invoice eu adiciono no dicionario para 
                             * poder adicionar os items dele */                            
                            if (!invoiceDictionary.TryGetValue(invoice.InvoiceID, out invoiceEntry))
                            {
                                invoiceEntry = invoice;
                                invoiceEntry.Items = new List<InvoiceItem>();
                                invoiceDictionary.Add(invoiceEntry.InvoiceID, invoiceEntry);
                            }

                            invoiceEntry.Items.Add(invoiceItem);
                            return invoiceEntry;
                        },
                        /* The splitOn param needs to be specified as the split point, 
                         * it defaults to Id. If there are multiple split points, 
                         * you will need to add them in a comma delimited list.*/
                        splitOn: "InvoiceItemID") 
                    /* é necessario o distinct porque sem ele a query vai retornar a lista 
                     * com itens repetidos porque para cada linha do banco de dados 
                     * ele entra dentro da rotina e cada vez que ele entra na rotina 
                     * ele retorna uma propriedade no caso um invoice*/
                    .Distinct()
                    .ToList();

                My.Result.Show(invoices);
            }
        }
    }
}