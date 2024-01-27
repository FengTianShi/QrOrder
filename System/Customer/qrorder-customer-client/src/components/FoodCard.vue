<template>
  <div class="card">
    <div class="card-body p-0">
      <div class="card border-0">
        <img
          src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRYm2LKmGDspWPFpuf2cSqBAvQiW4LTcHAPaw&usqp=CAU"
          class="card-img-top object-fit-cover"
          style="height: 120px" />
        <div class="p-2">
          <p class="card-text mb-1">
            <strong>マグロの中マグロ</strong>
          </p>

          <p class="card-text">
            <strong class="me-2">
              <span class="text-danger me-1">$ 2,099</span>
              <small class="text-secondary">税込み</small>
            </strong>

            <a
              href="#"
              class="stretched-link"
              data-bs-toggle="modal"
              data-bs-target="#foodModal">
              <i class="bi bi-cart4" style="font-size: 18px; color: red" />
            </a>
          </p>
        </div>
      </div>

      <p class="card-text p-2">
        <button type="button" class="btn btn-sm btn-light rounded-circle">
          <i class="bi bi-dash-lg" />
        </button>
        <span class="text-secondary mt-1 px-2" style="width: 18px">0</span>
        <button type="button" class="btn btn-sm btn-light rounded-circle">
          <i class="bi bi-plus-lg" />
        </button>
      </p>
    </div>
  </div>
</template>

<script>
export default {
  props: {},
};
</script>

<style scoped></style>
