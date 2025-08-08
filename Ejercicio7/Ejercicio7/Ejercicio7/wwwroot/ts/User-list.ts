interface User {
    id: number;
    name: string | null;
    email: string | null;
    age: number | null;
}

async function GetUsers(): Promise<void> {
    const answer = await fetch('/api/UserAPi');
    const Users: User[] = await answer.json();
    const lista = document.getElementById('userList') as HTMLUListElement;
    lista.innerHTML = '';
    Users.forEach((usuario) => {
        const li = document.createElement('li');
        li.textContent = `ID: ${usuario.id}, Nombre: ${usuario.name}, Email: ${usuario.email}, Edad: ${usuario.age}`;
        lista.appendChild(li);
    });
}
document.addEventListener('DOMContentLoaded', () => {
    GetUsers();
});

