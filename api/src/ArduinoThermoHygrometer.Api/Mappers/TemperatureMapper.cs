﻿using ArduinoThermoHygrometer.Api.DTOs;
using ArduinoThermoHygrometer.Domain.Entities;

namespace ArduinoThermoHygrometer.Api.Mappers;

public static class TemperatureMapper
{
    /// <summary>
    /// Converts a TemperatureDto object to a Temperature object.
    /// </summary>
    /// <param name="temperatureDto">The TemperatureDto object to convert.</param>
    /// <returns>The converted Temperature object.</returns>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="temperatureDto"/> is null.</exception>
    public static Temperature GetTemperatureFromTemperatureDto(TemperatureDto temperatureDto)
    {
        ArgumentNullException.ThrowIfNull(temperatureDto, nameof(temperatureDto));

        Temperature temperature = new(temperatureDto.RegisteredAt, temperatureDto.Temp)
        {
            Id = temperatureDto.Id,
            RegisteredAt = temperatureDto.RegisteredAt,
            Temp = temperatureDto.Temp,
        };

        return temperature;
    }

    /// <summary>
    /// Converts a Temperature object to a TemperatureDto object.
    /// </summary>
    /// <param name="temperature">The Temperature object to convert.</param>
    /// <returns>The converted TemperatureDto object.</returns>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="temperature"/> is null.</exception>
    public static TemperatureDto GetTemperatureDtoFromTemperature(Temperature temperature)
    {
        ArgumentNullException.ThrowIfNull(temperature, nameof(temperature));

        return new TemperatureDto
        {
            Id = temperature.Id,
            RegisteredAt = temperature.RegisteredAt,
            Temp = temperature.Temp,
        };
    }
}