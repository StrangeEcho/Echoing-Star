import socket

def server_program() -> None:
    host = socket.gethostname() # Get host name for server
    port = 5000 # Declare a port for the server to use
    
    server_socket = socket.socket(socket.AF_INET6, socket.SOCK_STREAM) # Initialize our communication socket
    server_socket.bind((host, port)) # Bind socket server
    
    print(f"Socket Server created. Ready to accept connections at port: {port}")
    
    server_socket.listen(1) # Listen to and for only one client
    connection, address = server_socket.accept() # Accept client connection
    
    print(f"Established Socket Connection with: {address}")
    print(f"Listening on port: {port}")
    while True:
        data = connection.recv(1024).decode() # Wont accept a data packet greater than 1024 bytes
        if not data:
            break # No data recieved
        
        print(f"From connected client: {data}")
        to_send = input("-> ")
        connection.send(to_send.encode())
        
    connection.close() # Close connection upon loop breaking 
    
if __name__ == "__main__":
    server_program()