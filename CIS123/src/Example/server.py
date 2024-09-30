import socket


def server_program() -> None:
    host = "127.0.0.1" # Establish host for the server to bind to
    port = 5000 # Establish port for the server to bind to

    server_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM) # Initialize our communication socket
    server_socket.bind((host, port)) # Bind socket server to a specified host and port
    print(f"Socket Server binded. Listening for connections at {host}:{port}")
    
    server_socket.listen(1) # Listen to and for only one client connection
    connection, address = server_socket.accept() # Accept client connection
    
    print(f"Established Socket Connection with: {address}")
    while True:
        data = connection.recv(1024).decode() # Wont accept a data packet with a buffer less than 1024 bytes
        if not data:
            break # No data recieved
        
        print(f"Recieved from connected client across socket tunnel:\n{data}")
        to_send = input("-> ")
        connection.send(to_send.encode()) # Send encoded message to client
        
    connection.close() # Close connection upon loop breaking 
    
if __name__ == "__main__":
    server_program()