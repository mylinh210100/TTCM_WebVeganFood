var cart = {
    init: function () {
        cart.regEvents();
    },
    regEvents: function () {
        $('#btnContinue').off('click').on('click', function () {
            window.location.href = "/";
        });
        $('#btnUpdate').off('click').on('click', function () {
            var listProduct = $('.txtamount');
            var cartList = new Array();
            $.each(listProduct, function (i, item) {
                cartList.push({
                    Amount: $(item).val(),
                    IdProduct: $(item).data('id')
                });
            });
            $.ajax({
                url: '/Order/Update',
                data: { cartModel: JSON.stringify(cartList) },
                dataType: 'json',
                type: 'POST',
                success: function (res) {
                    if (res.status == true) {
                        window.location.href = '/order';
                    }
                }
            });
        });

    }
}
cart.init();