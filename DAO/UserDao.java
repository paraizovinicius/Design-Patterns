public interface UserDao {
    public User getUserById(int id);
    public List<User> getAllUsers();
    public void addUser(User user);
    public void updateUser(User user);
    public void deleteUser(int id);
}
