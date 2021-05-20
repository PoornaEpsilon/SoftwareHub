var buttons = document.querySelectorAll("#btn");

buttons.forEach(
    button => button.addEventListener('click', () => {
        var productIdent = button.getAttribute("idp");
        var productName = button.getAttribute("namep");
        var productbasicPrice = button.getAttribute("pricebp");
        var productstdPrice = button.getAttribute("pricesp");
        var productentPrice = button.getAttribute("priceep");
        var productDetail = button.getAttribute("detailp");
        var productCategory = button.getAttribute("categoryp");
        var productPoc = button.getAttribute("pocp");
        var productPocmail = button.getAttribute("pocmailp");
        var productPocPhone = button.getAttribute("pocphonep");

        localStorage.setItem('prod-id', productIdent);
        localStorage.setItem('prod-name', productName);
        localStorage.setItem('prod-bprice', productbasicPrice);
        localStorage.setItem('prod-sprice', productstdPrice);
        localStorage.setItem('prod-eprice', productentPrice);
        localStorage.setItem('prod-detail', productDetail);
        localStorage.setItem('prod-category', productCategory);
        localStorage.setItem('prod-poc', productPoc);
        localStorage.setItem('prod-pocmail', productPocmail);
        localStorage.setItem('prod-pocphone', productPocPhone);
})); 