interface User {
    id: number;
    name: string | null;
    lastName: string | null
}
/// Función para obtener los usuarios desde la API y mostrarlos en la lista
async function GetUsers(): Promise<void> {
    const getAnswer = await fetch('/api/UserAPi');
    const users:User[] = await getAnswer.json();
    const userList = document.getElementById('user-list') as HTMLUListElement;
    userList.innerHTML = ''; // Limpiar la lista antes de agregar nuevos usuarios
    users.forEach(u => {
        const li = document.createElement('li');
        li.textContent = `ID:${u.id} \nNombre:${u.name} \nApellido:${u.lastName}`;
        li.style.whiteSpace = 'pre-line'; // para que los \n funcionen
        userList.appendChild(li);
    });


}
// fucnion para enviar 
async function PostUser(name: string, lastName: string): Promise<void> {
    const response = await fetch('/api/UserAPi', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({ name, lastName })
    });

    if (response.ok) {
        // Si todo salió bien, puedes actualizar la lista
        await GetUsers();
    } else {
        alert('Error al enviar el usuario');
    }
    
}



document.addEventListener('DOMContentLoaded', () => {
    const form = document.getElementById('user-form') as HTMLFormElement;
    GetUsers(); // Llamar a la función para obtener los usuarios al cargar la página
    form.addEventListener('submit', async (e) => {
        e.preventDefault(); // Prevenir el envío del formulario
        const formData = new FormData(form);
        const name = formData.get('name')?.toString() || '';
        const lastName = formData.get('lastName')?.toString() || '';
        await PostUser(name, lastName);
        form.reset(); // Limpiar el formulario después de enviar
    })
    
});

//estudia los nuevos metodos PostUser y event listener del formulario