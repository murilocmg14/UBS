using IT_DEV_RISK;
using IT_DEV_RISK.Category;
using IT_DEV_RISK.Handlers;
using IT_DEV_RISK.Interfaces;

var categories = new List<ICategory>()
{
    new ExpiredCategory(),
    new HighRiskCategory(),
    new MediumRiskCategory(),
};

var referenceDate = ReferenceDateHandler.AskReferenceDate();
var trades = new TradeHandler().AskForOperations();

ValidateHandler.Validate(categories, referenceDate, trades);