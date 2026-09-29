const {add} = require("./Math.js")

let num = 42;
var name = "TOM";
let isStudent = true;   //bool


let color = ["red" , "green" , "blue"]
let person = {name : "Alice" , age : 30};

console.log(add(num,num));

function greet(name)
{
    console.log("Hello" + name + " ! ");
}

greet(person.name);

//조건문
if(num > 30)
{
    console.log("Number is greater than 30")

}
else
{
    console.log("Number is lower than 30");
}

//반복문
for(var i = 0; i < 5; i++)
{
    console.log(i);
}

//비동기 콜백
setTimeout(() => {
    console.log("Delayed Message 1");
}, 1000); //1초

setTimeout(() => {
    console.log("Delayed Message 2");
}, 750); //0.75초

setTimeout(() => {
    console.log("Delayed Message 3");
}, 2000); //2초

setTimeout(() => {
    console.log("Delayed Message 4");
}, 500); //0.5초