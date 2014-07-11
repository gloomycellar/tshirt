function CartItem(product, quontity) {
    this.product = product;
    this.quontity = quontity;
}

CartItem.prototype = {
    getSubTotalPrice: function () {
        return this.product.price * this.quontity;
    }
}

app.factory("cartService", function ($http, $q) {
    return {
        cartItems: [],

        add: function (product, quontity) {
            var current;

            if (quontity < 0) {
                throw "Quantity cannot be fewer than 0."
            }

            for (var index = 0; index < this.cartItems.length; index++) {
                current = this.cartItems[index];
                if (product.id == current.product.id) {
                    current.quontity += quontity;
                    return;
                }
            }

            this.cartItems.push(new CartItem(product, quontity));
        },

        remove: function (product, quontity) {
            var current;

            if (quontity < 0) {
                throw "Quantity cannot be fewer than 0."
            }

            for (var index = 0; index < this.cartItems.length; index++) {
                current = this.cartItems[index];
                if (product.id == current.product.id) {
                    if ((current.quontity - quontity) > 0) {
                        current.quontity -= quontity;
                    } else {
                        this.cartItems.splice(index, 1);
                    }
                    return;
                }
            }
        },
               
        getTotalPrice: function () {
            var total = 0;

            for (var index = 0; index < this.cartItems.length; index++) {
                total += this.cartItems[index].getSubTotalPrice();
            }

            return total;
        }
    }
});