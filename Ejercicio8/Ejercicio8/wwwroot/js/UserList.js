var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
/// Función para obtener los usuarios desde la API y mostrarlos en la lista
function GetUsers() {
    return __awaiter(this, void 0, void 0, function* () {
        const getAnswer = yield fetch('/api/UserAPi');
        const users = yield getAnswer.json();
        const userList = document.getElementById('user-list');
        userList.innerHTML = ''; // Limpiar la lista antes de agregar nuevos usuarios
        users.forEach(u => {
            const li = document.createElement('li');
            li.textContent = `ID:${u.id} \nNombre:${u.name} \nApellido:${u.lastName}`;
            li.style.whiteSpace = 'pre-line'; // para que los \n funcionen
            userList.appendChild(li);
        });
    });
}
// fucnion para enviar 
function PostUser(name, lastName) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch('/api/UserAPi', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({ name, lastName })
        });
        if (response.ok) {
            // Si todo salió bien, puedes actualizar la lista
            yield GetUsers();
        }
        else {
            alert('Error al enviar el usuario');
        }
    });
}
document.addEventListener('DOMContentLoaded', () => {
    const form = document.getElementById('user-form');
    GetUsers(); // Llamar a la función para obtener los usuarios al cargar la página
    form.addEventListener('submit', (e) => __awaiter(void 0, void 0, void 0, function* () {
        var _a, _b;
        e.preventDefault(); // Prevenir el envío del formulario
        const formData = new FormData(form);
        const name = ((_a = formData.get('name')) === null || _a === void 0 ? void 0 : _a.toString()) || '';
        const lastName = ((_b = formData.get('lastName')) === null || _b === void 0 ? void 0 : _b.toString()) || '';
        yield PostUser(name, lastName);
        form.reset(); // Limpiar el formulario después de enviar
    }));
});
export {};
//estudia los nuevos metodos PostUser y event listener del formulario
//# sourceMappingURL=UserList.js.map