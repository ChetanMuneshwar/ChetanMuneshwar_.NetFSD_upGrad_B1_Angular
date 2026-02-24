let sales = [100, 500, 900, 280, 910, 1120, 200];
let days = ["Mon", "Tues", "Wed", "Thur", "Fri", "Sat", "Sun"];

let total = 0;

let bestDay = days[0];
let worstDay = days[0];

let maxSales = sales[0];
let minSales = sales[0];

for (let i = 0; i < sales.length; i++) {
    total += sales[i];

    if (sales[i] > maxSales) {
        maxSales = sales[i];
        bestDay = days[i];
    }

    if (sales[i] < minSales) {
        minSales = sales[i];
        worstDay = days[i];
    }
}
console.log("Total Weekly Sales:", total);
console.log("Best Day:", bestDay + " = " + maxSales );
console.log("Worst Day:", worstDay + " = " + minSales);
