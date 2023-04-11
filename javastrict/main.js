/***
 * Coments
 * 
 * 1.Muc dich su dung
 * -Ghi chu
 */

//alert
//confirm
//console. error(fullName)
//prompt  
//setTimeout
//setInterval

//prompt('Xac dinh ban du tuoi!')
/**setTimeout(function() {
    alert('Thong bao')

},1000)*/


 var a=5;
 var b= 6;
 var c=a+b;
 console.log(c);
 var n=6;
 var output=a++;
console.log('output',output)
var output=n++ + --n;
//Toan tu so sanh

var a=1;
var b=2;
if(a==b){
    console.log('Dieu kien dung');

}else{
    console.log('Dieu kien saii');
     

}
/**
 * Boolean
 */
var a=2;
var b = 4;
var Q=a>b;
console.log(Q);
/**
 * cau lenh dieu kien if -else
 */
var c =9;
var  d=7;
if(c==d){
    console.log('Dieu kien dung')

}else{
    console.log('Dieu kien sai')

}
/**  gia trị dieu kien sai 
 * 0: 
 * false
 * " "
 * underfined
 * NaN
 * null:
 */

/**
 * Toán tử logic
 * 1. && - AND
 * 2. || - OR
 * 3. ! - NOT 
 */

var a = 1;
var b= 2;
var c= 3;

if(a > 0 && c > 0 ){
    console.log("Dieu kien đung ");
}

/**
 * Kiểu dữ liệu trong Javasr
 *  1. Dữ liệu nguyên thuỷ -Primitive Data 
 * Number  : 1,2,3,4,5,
 * String :'Chu Thuy Dien'
 * Boolean : true , false
 * Underfinend : var age
 * Null :
 * Symbol: id =Symbol ('id');
 * 2.Dữ liệu phức tạp - Complex Data
 * Fuction  : 
 * Object
 */


//Toán tử so sánh 
/**
 * ===
 * !==
 */
var e=9;
var f=8;
var h=e+f;
if(e+f<  0){
    console.log('Dieu kiện đúng ');
}
else{
    console.log('Dieu kiên sai ')
}

var a=1;
var b=2;
var rusult =('A'  && 'B' && 'C');
console.log(rusult);
/**
 * CHUỖI TRONG JAVASCRIPT
 */
//1.Tạo chuỗi 
// -Các cách tạo chuỗi 
//- Cách 1:
var fullName= 'Chu Thuy Dien';
//-Cách 2:
var  fullName=new String ('Chu ThuyDiennnnnnnnn');
console.log(fullName); 
// 2. Một số case sử dụng backlash(\)
var Hoten='Toi la aiii\'The Bigboss';
console.log(Hoten)
//3.Xem độ dài chuỗi
var TEN ='lythuyanh'
console.log(TEN.length)

var fistName ='Thuy '
var lastName='Dien'

/**
 * LÀM VIỆC VỚI CHUỖI
 * 
 */ 

 var mString ='hoc tai day ai '
 // length
 console.log(mString.length);
 //find index
 console.log(mString.indexOf('ai ',6 ))
 //cut string
 console .log(myString.slice(2,3))
 //replace
 console.log(myString.replace('hoc', 'khong'));
//Kieu so Number
var age=18;
var PI=3.2 ;
var otherNumber=new new Number(9);

// cách tạo mảng
var languages=[
    'Javascript', // phần tử của mảng 
    'PHP',
    'Ruby',
];
console.log(languages)

var languages=new Array();
'Javascript', // phần tử của mảng 
    'PHP',
    'Ruby'
//Kiểm tra phần dữ liệu 
console.log(Array(languages))
// độ dài mảng 
console.log(languages.length)

// Làm việc với Array
// to string
var languages=[
    'JaVa',
    'PHP',
    'Ruby'
];
consolo .log(languages.toString()); 
console.log(languages.join(','))

// pop : Xoá đi phần tử cuối mảng và trả di phan tu đã xoá
console.log(languages.pop());
// push : thêm phần tử ở cuối mẳng
console.log(languages.push('dart','html'));
console.log(languages)
// shift:xoá di phần tử đầu mảng
console.log(languages.shift())
//unshift:thêm một hoặc nhiều phần tử đầu mảng
//splicing :xoá ,cắt hoặc chèn phần tử vào mảng
languages.slice(1,  1)
// concat: 
var languages2=[
    'Dart',
    'Ruby'
];
 console.log(languages.concat(languages2))
 // Slicing: cắt toàn bộ element
 console.log(languages.slice(1,2))
  


 /**Hàm co ban
  * 
  * a-z A-Z 0-9
  */
 function showDialog(){
    alert('Hi xin chao các bạn!');
 }

 // return trong hàm 
 
 var isconfirm=confirm ('Message?'); 
 

 function cong(a,b){
    return(a+b)
 }
 var  rusult=cong (2,8)
 console.log(rusult)

 /**
  * Chuỗi trong java
  * 
  */

 var fullName='ctd';
 var fullName= new String('ctd');
 var fullName='';
 console.log(fullName)


 /*
 CÁc loại fuction
 */
// 1.Declaration function
function showMes(){
    console.log('Chu');

}
//Expression fuction
var showMes=function test(){
    console.log('Exxpreeee');

}
showMes();
//Polyfill?
if(String .prototype.includes){
     String .prototype.includes=function(search,start){
        'use strict';


        if(search instanceof RegExp){
            throw TypeError('first argument ....')
        }
        if(start===undefined){
            start==0;
            return this.indexOf(search,start)!==-1;
        }

     }
}
'javascript course'.includes('javascript',0)
//Ojbect
var myInfo={
    name :'Ctd',age :19

};
console.log(myInfo)
myInfo.email=''


var myFunction;
function myFunction(){
    name: 'Thuy dien',
    age :'18',
}