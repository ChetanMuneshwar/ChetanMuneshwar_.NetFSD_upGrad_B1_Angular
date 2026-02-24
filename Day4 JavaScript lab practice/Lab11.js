// total salary of employee
// avarage of their salary
// print only salary wich are above avarage

let salaries = [25000, 30000, 28000, 40000, 35000];

let total = 0;

for(let i = 0; i<salaries.length ; i++) {
    total += salaries[i];
}
console.log("total : "+total);

let average = total/salaries.length;
console.log("Avarage : "+average);


console.log("Above average salary : ");
for (let i = 0; i < salaries.length; i++) {
    if (salaries[i] > average) {
        console.log(salaries[i]);
    }
}