interface User {
    id: number;
    name: string | null;
    email: string | null;
    age: number | null;
}

async function cargarUsuarios(): Promise<void> {
    const respuesta = await fetch('/api/UserApi');
    const usuarios: User[] = await respuesta.json();

    const lista = document.getElementById('userList') as HTMLUListElement;
    lista.innerHTML = '';

    usuarios.forEach((usuario) => {
        const li = document.createElement('li');
        li.textContent = `ID: ${usuario.id}, Nombre: ${usuario.name}, Email: ${usuario.email}, Edad: ${usuario.age}`;
        lista.appendChild(li);
    });
}

document.addEventListener('DOMContentLoaded', () => {
    cargarUsuarios();
});
