namespace QueryBuilder.Abstractions.Wheres;

public class WhereBuilder : IWhereBuilder
{
    private readonly List<string> _conditions = new List<string>();
    private readonly Dictionary<string, object> _parameters = new Dictionary<string, object>();
    private int _parameterCount = 0;

    private string GenerateParameterName()
    {
        _parameterCount++;
        return $"@param{_parameterCount}";
    }

    public IWhereBuilder Equal(string columnName, int parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} = {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder Equal(string columnName, string parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} = {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder Equal(string columnName, DateTime parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} = {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder Equal(string columnName, DateOnly parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} = {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder Equal(string columnName, long parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} = {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder NotEqual(string columnName, int parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} != {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder NotEqual(string columnName, string parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} != {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder NotEqual(string columnName, DateTime parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} != {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder NotEqual(string columnName, DateOnly parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} != {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder NotEqual(string columnName, long parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} != {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder Bigger(string columnName, int parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} > {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder Bigger(string columnName, string parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} > {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder Bigger(string columnName, DateTime parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} > {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder Bigger(string columnName, DateOnly parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} > {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder Bigger(string columnName, long parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} > {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder BiggerOrEqual(string columnName, int parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} >= {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder BiggerOrEqual(string columnName, string parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} >= {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder BiggerOrEqual(string columnName, DateTime parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} >= {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder BiggerOrEqual(string columnName, DateOnly parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} >= {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder BiggerOrEqual(string columnName, long parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} >= {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder Smaller(string columnName, int parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} < {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder Smaller(string columnName, string parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} < {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder Smaller(string columnName, DateTime parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} < {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder Smaller(string columnName, DateOnly parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} < {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder Smaller(string columnName, long parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} < {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder SmallerOrEqual(string columnName, int parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} <= {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder SmallerOrEqual(string columnName, string parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} <= {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder SmallerOrEqual(string columnName, DateTime parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} <= {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder SmallerOrEqual(string columnName, DateOnly parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} <= {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder SmallerOrEqual(string columnName, long parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} <= {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder Like(string columnName, int parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} LIKE {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder Like(string columnName, string parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} LIKE '%' + {paramName} + '%'");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder Like(string columnName, DateTime parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} LIKE {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder Like(string columnName, DateOnly parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} LIKE {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public IWhereBuilder Like(string columnName, long parameter)
    {
        var paramName = GenerateParameterName();
        _conditions.Add($"{columnName} LIKE {paramName}");
        _parameters[paramName] = parameter;
        return this;
    }

    public string Build()
    {
        return string.Join(" AND ", _conditions);
    }

    public Dictionary<string, object> GetParameters()
    {
        return _parameters;
    }
}