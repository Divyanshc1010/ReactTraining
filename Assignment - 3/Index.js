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