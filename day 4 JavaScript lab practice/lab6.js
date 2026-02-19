// find total marks and avarage 
// and based on the avarage marks find the grade of student

let marks = [80,65,85,85,86,88];

let total = 0;

for (let i = 0; i < marks.length; i++) 
    {
    total += marks[i];
}
console.log(total);

let average = total / marks.length ;
console.log(average);

let grade ;

if(average >= 90)
{
    grade = "A";
} else if (average >= 75)
{
    grade = "B";
} else if (average >= 60)
{
    grade = "C";
} else {
    grade = "Fail";
}

console.log("Marks:", marks);
console.log("Total:", total);
console.log("Average:", average);
console.log("Grade:", grade);