const quizData=[
    {
        question:'How old is Florin?',
        a: '10',
        b :'17',
        c:'26',
        d:'110',
        correct:'c'
    },{
        question:'What is the best programing langguage in 2020',
    a:'Java',
    b:'C',
    c:'Python',
    d:'javascript',
    correct :'a'
    }, {
        question:'Who is the President of US?',
        a:'Flon Pop',
        b:'Donnal Trump',
        c:'Ivan Saldano',
        d:'Mihai Andrei',
        correct :'b'
    },{
        question:'What does HTML stand for?',
        a:'Hypertext Markup Language',
        b:'Cascading Sytle Sheet',
        c:'Jason Object Notation',
        d: 'Heli Ter Mottoo Lamvooo',
        correct: 'a'
    },{
        question:'What year was JavaScript lanuched',
        a:'2020',
        b: '2019',
        c:'2018',
        d:'none of the abouve',
        correct :'d'
    }
]
const questionEL=document.getElementById('question')
 const a_text=document.getElementById('a_text');
 const b_text=document.getElementById('b_text');
const c_text=document.getElementById('c_text');
const d_text=document.getElementById('d.text');

let currenQuestion =0;
loadQuiz();
function loadQuiz(){
    const currenQuestion=quizData
    questionEL.innerHTML=quizData[currenQuestion]
    currenQuestion++;
}
