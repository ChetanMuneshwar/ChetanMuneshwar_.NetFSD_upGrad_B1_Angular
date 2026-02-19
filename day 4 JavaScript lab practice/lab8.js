// find total
//apply 10% discount if total > 1000
// display final amount

let prices = [250, 400, 300, 200];

let total = 0;

for (let i = 0; i < prices.length; i++) {
    total += prices[i];
}
console.log("total : "+total);

let discount = 0;

if(total > 1000)
{
    discount = (total/100)*10;
}

console.log("Discount : "+discount);

let finalBill = total - discount;
console.log("Final Ammount to PAY: "+finalBill);