using Clase_26.Entidades;
public delegate void LimiteSueldoDelegado(double sueldo, Empleado emp);
public delegate void LimiteSueldoMejoradoDel(Empleado empleado, EmpleadoEventArgs empleadoEventArgs);
public enum TipoManejador
{
    LimiteSueldo,
    LimiteSueldoMejorado,
    Todos,
}