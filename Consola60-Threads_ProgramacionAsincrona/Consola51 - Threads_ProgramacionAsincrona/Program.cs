public async Task RegisterMaintenanceAsync(int vehicleId, MaintenanceRecord record)
{
    using (var transaction = await _context.Database.BeginTransactionAsync())
    {
        try
        {
            // Operación 1: Obtener vehículo
            var vehicle = await _context.Vehicles.FindAsync(vehicleId);

            // Operación 2: Agregar registro de mantenimiento
            vehicle.AddMaintenanceRecord(record);
            await _context.SaveChangesAsync();

            // Confirmar transacción
            await transaction.CommitAsync();
        }
        catch
        {
            // Revertir transacción en caso de error
            await transaction.RollbackAsync();
            throw;
        }
    }
}

public interface IMessageService
{
    void SendMessage(string message);
}
public class EmailService : IMessageService
{
    public void SendMessage(string message) {// Send email
    }
}
public class Notification
{
    private readonly IMessageService _messageService;

    public Notification(IMessageService messageService) {
        _messageService = messageService;
    }

    public void Send(string message) {
        _messageService.SendMessage(message);
    }
}


    // Inicializamos el semáforo para permitir un máximo de 3 hilos simultáneamente
    private static Semaphore semaphore = new Semaphore(3, 3);

    public static void AccessResource(object id)
    {
        Console.WriteLine($"Hilo {id} está esperando para entrar...");

        // Intentamos entrar en la sección crítica
        semaphore.WaitOne();
        Console.WriteLine($"Hilo {id} ha entrado en la sección crítica.");

        // Simulamos una operación que lleva tiempo
        Thread.Sleep(2000);  

        // Salimos de la sección crítica y liberamos el semáforo
        Console.WriteLine($"Hilo {id} está saliendo de la sección crítica.");
        semaphore.Release();
    }

    public static void Main()
    {
        // Creamos varios hilos que intentarán acceder al recurso compartido
        for (int i = 1; i <= 10; i++)
        {
            Thread thread = new Thread(AccessResource);
            thread.Start(i);
        }
    }

