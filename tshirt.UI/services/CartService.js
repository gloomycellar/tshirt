function CartItem(product, quontity) {
    this.product = product;
    this.quontity = quontity;
}

CartItem.prototype = {
    getSubTotalPrice: function () {
        return this.product.price * this.quontity;
    }
};

app.factory("cartService", function ($http, $q, configService) {
    return {
        cartItems: [],

        getItem: function (productId) {
            for (var index = 0; index < this.cartItems.length; index++) {
                current = this.cartItems[index];
                if (productId === current.product.id) {
                    return current;
                }
            }

            return null;
        },

        add: function (product, quontity) {
            if (quontity < 0) {
                throw "Quantity cannot be fewer than 0.";
            }

            var current = this.getItem(product.id);
            if (current !== null) {
                current.quontity += quontity;
                return;
            }

            this.cartItems.push(new CartItem(product, quontity));
        },

        remove: function (product, quontity) {
            if (quontity < 0) {
                throw "Quantity cannot be fewer than 0.";
            }

            var current = this.getItem(product.id);
            if (current !== null) {
                if ((current.quontity - quontity) > 0) {
                    current.quontity -= quontity;
                } else {
                    for (var index = 0; index < this.cartItems.length; index++) {
                        if (product.id === this.cartItems[index].product.id) {
                            this.cartItems.splice(index, 1);
                        }
                    }
                }
            }
        },

        getTotalPrice: function () {
            var total = 0;

            for (var index = 0; index < this.cartItems.length; index++) {
                total += this.cartItems[index].getSubTotalPrice();
            }

            return total;
        },

        saveState: function () {
            var array = [];
            for (var index = 0; index < this.cartItems.length; index++) {
                array.push({ productId: this.cartItems[index].product.id, quontity: this.cartItems[index].quontity });
            }

            return $http.post(configService.serviceBase + '/order', array).then(function (response) {
                return response;
            });
        }
    };
});