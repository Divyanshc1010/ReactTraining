const args=document.getElementById("root");
const obj={};
Object.defineProperty(obj,"name",{
    get()
    {
        return args.value;
    },
    set(newValue)
    {
        args.value=newValue;
    }
});

setInterval(()=>{
    obj.name=Math.floor(Math.random()*100);
},5000);

function changeInput(event)
{
    obj.name=event.target.value;
    alert("Variable value is: "+obj.name);
}
