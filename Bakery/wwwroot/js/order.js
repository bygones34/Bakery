var unitPriceElement = document.querySelector('#UnitPrice');
var quantityElement = document.querySelector('#Quantity');
var orderTotalElement = document.querySelector('#orderTotal');
if (quantityElement && unitPriceElement && orderTotalElement) {
    quantityElement.addEventListener('change', function (_) {
        var unitPrice = Number(unitPriceElement.value);
        var quantity = Number(quantityElement.value);
        var orderTotal = unitPrice * quantity;
        orderTotalElement.textContent = orderTotal.toLocaleString('tr-TR', {
            style: 'currency',
            currency: 'TRY',
        });
    });
}
//# sourceMappingURL=order.js.map