
var nameSpan = document.getElementById("name");
var basicpriceSpan = document.getElementById("basicprice");
var stdpriceSpan = document.getElementById("stdprice");
var entpriceSpan = document.getElementById("entprice");
var detailSpan = document.getElementById("detail");
var CategorySpan = document.getElementById("category");



var productname = localStorage.getItem('prod-name');
localStorage.removeItem('prod-name');

var productbasicprice = localStorage.getItem('prod-bprice');
localStorage.removeItem('prod-bprice');

var productstdprice = localStorage.getItem('prod-sprice');
localStorage.removeItem('prod-sprice');

var productentprice = localStorage.getItem('prod-eprice');
localStorage.removeItem('prod-eprice');

var detail = localStorage.getItem('prod-detail');
localStorage.removeItem('prod-detail');

var category = localStorage.getItem('prod-category');
localStorage.removeItem('prod-category');


nameSpan.textContent = productname;
detailSpan.textContent = detail;
CategorySpan.textContent = category;
basicpriceSpan.textContent = "Basic edition: Price " + productbasicprice;
stdpriceSpan.textContent = "Standard edition: Price " + productstdprice;
entpriceSpan.textContent = "Enterprise edition: Price " + productentprice;

document.getElementById("ProductId").setAttribute('value', localStorage.getItem('prod-id'));
document.getElementById("ProductName").setAttribute('value', productname);

