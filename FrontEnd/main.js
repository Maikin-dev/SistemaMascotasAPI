    // URL de la API
    const API_URL = 'https://localhost:7021/api/ControladorMascotas';

    // Función para obtener los datos de la API
    async function fetchMascotas() {
      try {
        const response = await fetch(API_URL);
        if (!response.ok) {
          throw new Error(`Error: ${response.status} ${response.statusText}`);
        }
        const data = await response.json();
        renderTable(data);
      } catch (error) {
        console.error('Error al obtener los datos:', error);
      }
    }

    // Función para renderizar la tabla
    function renderTable(mascotas) {
      const tableBody = document.querySelector('#mascotas-table tbody');
      tableBody.innerHTML = ''; // Limpiar contenido previo

      mascotas.forEach(mascota => {
        const row = document.createElement('tr');
        row.innerHTML = `
          <td>${mascota.nombre}</td>
          <td>${mascota.raza}</td>
          <td>${mascota.edad}</td>
        `;
        tableBody.appendChild(row);
      });
    }

    // Llamar a la función para obtener y mostrar los datos al cargar la página
    fetchMascotas();