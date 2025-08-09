var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
function GetUsers() {
    return __awaiter(this, void 0, void 0, function* () {
        const getAnswer = yield fetch('/api/UserAPi');
        const users = yield getAnswer.json();
        const userList = document.getElementById('user-list');
        users.forEach(u => {
            const li = document.createElement('li');
            li.textContent = `ID:${u.id} \nNombre:${u.name} \nApellido:${u.lastName}`;
            li.style.whiteSpace = 'pre-line'; // para que los \n funcionen
            userList.appendChild(li);
        });
    });
}
document.addEventListener('DOMContentLoaded', () => {
    GetUsers();
});
export {};
//# sourceMappingURL=UserList.js.map