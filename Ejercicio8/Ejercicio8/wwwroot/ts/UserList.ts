interface User {
    id: number;
    name: string | null;
    lastName: string | null;
}
async function GetUsers(): Promise<void> {
    const getAnswer = await fetch('/api/UserAPi');
    const users: User[] = await getAnswer.json();
    const userList = document.getElementById('user-list') as HTMLUListElement;
    users.forEach(u => {
        const li = document.createElement('li');
        li.textContent = `ID:${u.id} \nNombre:${u.name} \nApellido:${u.lastName}`;
        li.style.whiteSpace = 'pre-line'; // para que los \n funcionen
        userList.appendChild(li);
    });


}
document.addEventListener('DOMContentLoaded', ()=>{
    GetUsers();
})