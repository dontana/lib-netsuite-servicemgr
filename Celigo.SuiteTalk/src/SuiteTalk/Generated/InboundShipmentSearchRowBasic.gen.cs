//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class InboundShipmentSearchRowBasic
    {
        // TODO: Make this Lazy and Weak referenced so that it can be garbaged collected
        private static readonly Lazy<ColumnFactory> columnFactoryLoader = new Lazy<ColumnFactory>(() => new ColumnFactory());

        public override void SetColumns(string[] columnNames)
        {
            var factory = columnFactoryLoader.Value;
            for (int i = 0; i < columnNames.Length; i++)
            {
                factory.BuildColumn(this, columnNames[i]);
            }
        }

        class ColumnFactory:  ColumnFactory<InboundShipmentSearchRowBasic>
        {
            protected override Dictionary<string, Action<InboundShipmentSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<InboundShipmentSearchRowBasic>> {
                    { "actualDeliveryDate", r => r.@actualDeliveryDate = new [] { new SearchColumnDateField { customLabel = "actualDeliveryDate" } } },
                    { "actualShippingDate", r => r.@actualShippingDate = new [] { new SearchColumnDateField { customLabel = "actualShippingDate" } } },
                    { "billOfLading", r => r.@billOfLading = new [] { new SearchColumnStringField { customLabel = "billOfLading" } } },
                    { "createdDate", r => r.@createdDate = new [] { new SearchColumnDateField { customLabel = "createdDate" } } },
                    { "currency", r => r.@currency = new [] { new SearchColumnSelectField { customLabel = "currency" } } },
                    { "description", r => r.@description = new [] { new SearchColumnStringField { customLabel = "description" } } },
                    { "expectedDeliveryDate", r => r.@expectedDeliveryDate = new [] { new SearchColumnDateField { customLabel = "expectedDeliveryDate" } } },
                    { "expectedRate", r => r.@expectedRate = new [] { new SearchColumnDoubleField { customLabel = "expectedRate" } } },
                    { "expectedShippingDate", r => r.@expectedShippingDate = new [] { new SearchColumnDateField { customLabel = "expectedShippingDate" } } },
                    { "externalDocumentNumber", r => r.@externalDocumentNumber = new [] { new SearchColumnStringField { customLabel = "externalDocumentNumber" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "incoterm", r => r.@incoterm = new [] { new SearchColumnSelectField { customLabel = "incoterm" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "item", r => r.@item = new [] { new SearchColumnSelectField { customLabel = "item" } } },
                    { "landedCostAllocationMethod", r => r.@landedCostAllocationMethod = new [] { new SearchColumnEnumSelectField { customLabel = "landedCostAllocationMethod" } } },
                    { "landedCostAmount", r => r.@landedCostAmount = new [] { new SearchColumnDoubleField { customLabel = "landedCostAmount" } } },
                    { "landedCostCostCategory", r => r.@landedCostCostCategory = new [] { new SearchColumnSelectField { customLabel = "landedCostCostCategory" } } },
                    { "landedCostCurrency", r => r.@landedCostCurrency = new [] { new SearchColumnSelectField { customLabel = "landedCostCurrency" } } },
                    { "landedCostEffectiveDate", r => r.@landedCostEffectiveDate = new [] { new SearchColumnDateField { customLabel = "landedCostEffectiveDate" } } },
                    { "landedCostExchangeRate", r => r.@landedCostExchangeRate = new [] { new SearchColumnDoubleField { customLabel = "landedCostExchangeRate" } } },
                    { "memo", r => r.@memo = new [] { new SearchColumnStringField { customLabel = "memo" } } },
                    { "poAmount", r => r.@poAmount = new [] { new SearchColumnDoubleField { customLabel = "poAmount" } } },
                    { "poRate", r => r.@poRate = new [] { new SearchColumnDoubleField { customLabel = "poRate" } } },
                    { "purchaseOrder", r => r.@purchaseOrder = new [] { new SearchColumnSelectField { customLabel = "purchaseOrder" } } },
                    { "quantityBilled", r => r.@quantityBilled = new [] { new SearchColumnDoubleField { customLabel = "quantityBilled" } } },
                    { "quantityExpected", r => r.@quantityExpected = new [] { new SearchColumnDoubleField { customLabel = "quantityExpected" } } },
                    { "quantityReceived", r => r.@quantityReceived = new [] { new SearchColumnDoubleField { customLabel = "quantityReceived" } } },
                    { "quantityRemaining", r => r.@quantityRemaining = new [] { new SearchColumnDoubleField { customLabel = "quantityRemaining" } } },
                    { "receivingLocation", r => r.@receivingLocation = new [] { new SearchColumnSelectField { customLabel = "receivingLocation" } } },
                    { "shipmentBaseCurrency", r => r.@shipmentBaseCurrency = new [] { new SearchColumnSelectField { customLabel = "shipmentBaseCurrency" } } },
                    { "shipmentNumber", r => r.@shipmentNumber = new [] { new SearchColumnStringField { customLabel = "shipmentNumber" } } },
                    { "status", r => r.@status = new [] { new SearchColumnStringField { customLabel = "status" } } },
                    { "unit", r => r.@unit = new [] { new SearchColumnSelectField { customLabel = "unit" } } },
                    { "vendor", r => r.@vendor = new [] { new SearchColumnSelectField { customLabel = "vendor" } } },
                    { "vesselNumber", r => r.@vesselNumber = new [] { new SearchColumnStringField { customLabel = "vesselNumber" } } },
                };
            }
        }
    }
}