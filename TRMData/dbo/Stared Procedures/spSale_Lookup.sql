CREATE PROCEDURE [dbo].[spSale_Lookup]
	@CashierId nvarchar(128),
    @SaleDate datetime2
AS
BEGIN
	set nocount on;

	select Id
	from dbo.Sale
	WHERE CashierId = @CashierId AND SaleDate = @SaleDate
END
