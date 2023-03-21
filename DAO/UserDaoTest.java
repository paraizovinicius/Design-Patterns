public class UserDaoTest {
    public static void main(String[] args) {
        UserDao userDao = new UserDaoImpl();
 
        // teste do método getUserById
        User user1 = userDao.getUserById(1);
        System.out.println(user1.getName()); // deve imprimir o nome do usuário com ID 1
 
        // teste do método getAllUsers
        List<User> userList = userDao.getAllUsers();
        for (User user : userList) {
            System.out.println(user.getName()); // deve imprimir o nome de todos os usuários
        }
 
        // teste do método addUser
        User user2 = new User(2, "Maria", "maria@gmail.com");
        userDao.addUser(user2);
 
        // teste do método updateUser
        user2.setEmail("maria@yahoo.com");
        userDao.updateUser(user2);
 
        // teste do método deleteUser
        userDao.deleteUser(2);
    }
}
