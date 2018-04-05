//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class RevRecScheduleSearchRowBasic
    {
        private static readonly Lazy<ColumnFactory> columnFactoryLoader = new Lazy<ColumnFactory>(() => new ColumnFactory());

        public override void SetColumns(string[] columnNames)
        {
            var factory = columnFactoryLoader.Value;
            for (int i = 0; i < columnNames.Length; i++)
            {
                factory.BuildColumn(this, columnNames[i]);
            }
        }

        class ColumnFactory:  ColumnFactory<RevRecScheduleSearchRowBasic>
        {
            protected override Dictionary<string, Action<RevRecScheduleSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<RevRecScheduleSearchRowBasic>> {
                    { "accountingBook", r => r.@accountingBook = new [] { new SearchColumnSelectField { customLabel = "accountingBook" } } },
                    { "amorStatus", r => r.@amorStatus = new [] { new SearchColumnEnumSelectField { customLabel = "amorStatus" } } },
                    { "amorTemplate", r => r.@amorTemplate = new [] { new SearchColumnStringField { customLabel = "amorTemplate" } } },
                    { "amortizedAmount", r => r.@amortizedAmount = new [] { new SearchColumnDoubleField { customLabel = "amortizedAmount" } } },
                    { "amorType", r => r.@amorType = new [] { new SearchColumnEnumSelectField { customLabel = "amorType" } } },
                    { "amount", r => r.@amount = new [] { new SearchColumnDoubleField { customLabel = "amount" } } },
                    { "currency", r => r.@currency = new [] { new SearchColumnStringField { customLabel = "currency" } } },
                    { "deferredAmount", r => r.@deferredAmount = new [] { new SearchColumnDoubleField { customLabel = "deferredAmount" } } },
                    { "destAcct", r => r.@destAcct = new [] { new SearchColumnStringField { customLabel = "destAcct" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "initialAmt", r => r.@initialAmt = new [] { new SearchColumnDoubleField { customLabel = "initialAmt" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "isRecognized", r => r.@isRecognized = new [] { new SearchColumnBooleanField { customLabel = "isRecognized" } } },
                    { "jeDoc", r => r.@jeDoc = new [] { new SearchColumnStringField { customLabel = "jeDoc" } } },
                    { "lineSequenceNumber", r => r.@lineSequenceNumber = new [] { new SearchColumnLongField { customLabel = "lineSequenceNumber" } } },
                    { "name", r => r.@name = new [] { new SearchColumnStringField { customLabel = "name" } } },
                    { "nameUrl", r => r.@nameUrl = new [] { new SearchColumnStringField { customLabel = "nameUrl" } } },
                    { "pctComplete", r => r.@pctComplete = new [] { new SearchColumnDoubleField { customLabel = "pctComplete" } } },
                    { "pctRecognition", r => r.@pctRecognition = new [] { new SearchColumnDoubleField { customLabel = "pctRecognition" } } },
                    { "periodOffset", r => r.@periodOffset = new [] { new SearchColumnLongField { customLabel = "periodOffset" } } },
                    { "recurAmount", r => r.@recurAmount = new [] { new SearchColumnDoubleField { customLabel = "recurAmount" } } },
                    { "recurFxAmount", r => r.@recurFxAmount = new [] { new SearchColumnDoubleField { customLabel = "recurFxAmount" } } },
                    { "schedDate", r => r.@schedDate = new [] { new SearchColumnDateField { customLabel = "schedDate" } } },
                    { "scheduleNumber", r => r.@scheduleNumber = new [] { new SearchColumnStringField { customLabel = "scheduleNumber" } } },
                    { "sourceAcct", r => r.@sourceAcct = new [] { new SearchColumnStringField { customLabel = "sourceAcct" } } },
                    { "srcDocLine", r => r.@srcDocLine = new [] { new SearchColumnStringField { customLabel = "srcDocLine" } } },
                    { "srcTran", r => r.@srcTran = new [] { new SearchColumnStringField { customLabel = "srcTran" } } },
                    { "srcTranPostPeriod", r => r.@srcTranPostPeriod = new [] { new SearchColumnStringField { customLabel = "srcTranPostPeriod" } } },
                    { "startOffset", r => r.@startOffset = new [] { new SearchColumnLongField { customLabel = "startOffset" } } },
                    { "useForeignAmounts", r => r.@useForeignAmounts = new [] { new SearchColumnBooleanField { customLabel = "useForeignAmounts" } } },
                };
            }
        }
    }
}