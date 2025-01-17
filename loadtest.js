import http from "k6/http";
import { check } from "k6";

export let options = {
  noConnectionReuse: false,
  insecureSkipTLSVerify: true,
  scenarios: {
    max_load_test: {
      executor: 'constant-arrival-rate',
      rate: 30000, // Number of requests per second
      timeUnit: '1s', // The time unit over which 'rate' is defined
      duration: '1m', // Test duration (1 minutes)
      preAllocatedVUs: 20, // Preallocate 200 Virtual Users
      maxVUs: 100, // Allow up to 100 Virtual Users
    },
  },
};

export default function () {
  
  const id = 26866;
  const response = http.get(`https://localhost:7055/orders/${id}/cache`);

  check(response, {
    "status is 200": (r) => r.status === 200,
    "body is not empty": (r) => r.body.length > 0,
  });
}