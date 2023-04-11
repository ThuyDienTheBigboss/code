/**1. THAM SỐ
 * dinh nghia 
 * kieu du lieu 
 * tính private 
 * 1 tham so 
 * nhieu tham so
 * 
 * 2.Truyền tham số
 * 1 tham số 
 * Nhiều tham số
 * 
 * 3.Arguments
 * Đối tượng arguments
 * Giới thiệu vòng for
 */
function writeLog(mes){
    console. log(mes) // mes là tham số
}
writeLog('Test mesage') //đối số
// kiểu dữ liệu 
writeLog(123);('dsds');
//tính private 

// đối tượng arguments
function writeLog(){
    console.log(arguments)
}
writeLog('CHuTHUYDIENLYTHUYANH');

//vòng for of
function writeLog(){
    var myString='';
    for(var param of arguments){
       console.log(param) 
       myString +='${param}-'
    }
}
// return trong hàm
function cong(a,b){
    return a+b;
}
var rusult=cong(8,3);
console.log(rusult);
//
function showMes(){
    console.log('Mes1')
}
function showMes(){
    console.log('Mes2');
}
function showMes(){
    console.log('Mes3');
}

console.log(showMes);
// các loại fuctions



//ojbect trong 
var emailKey='email';
var myInfo=
{
    name:'Chu Thuy Dien', 
    age: 20,
    address:'ha noi'
    
};
myKey='address';
myInfo.emali='thuydiem@gmail.com'
console.log(myInfo[myKey]);





